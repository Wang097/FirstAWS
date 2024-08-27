public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
    if (env.IsDevelopment()) {
        app.UseDeveloperExceptionPage();
    } else {
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles(); 
    app.UseRouting();
    app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
    });
}
